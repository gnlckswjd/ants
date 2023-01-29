#include "pch.h"
#include "Session.h"

#include "Server.h"

Session::Session(unsigned sessionID, boost::asio::io_context& io_context, Server* server)
    : socket(io_context),_sessionID(sessionID),_server(server)
{

}

void Session::RegisterReceive()
{
    socket.async_read_some(
        boost::asio::buffer(_receiveBuffer),
        [this] (boost::system::error_code error,size_t transferedBytes){ AfterReceive(error, transferedBytes); }

    );
}

void Session::RegisterSend(const int nSize, char* pData)
{
    //네트워크에서 send는 보내는 것 뿐이야, 그렇다면 비즈니스 로직에서 어떠한 큐에 데이터를 넣고, 그 데이터를 꺼내서 전송을 하겠지 그러면 이 함수는 그냥 센드야
    char* sendData = nullptr;

    sendData = pData;


    boost::asio::async_write(
        socket, 
        boost::asio::buffer(sendData, nSize),
        [this](boost::system::error_code error, size_t transferredBytes) {AfterSend(error, transferredBytes); }
    );
}

void Session::AfterConnect()
{
    Init();
    RegisterReceive();
}


void Session::AfterSend(const boost::system::error_code& error, size_t transferredBytes)
{
    //끝났으니까 버퍼를 삭제한다 데이터를 어떻게 관리할래?
    //여기서 Send는 다시 호출될 필요 없어 왜? 비즈니스 로직에서 특정 시간마다 반복해서 send 할 거니까 여기는 필요한 작업 생기면 추가 해 그냥
    OnSend();
}

void Session::AfterReceive(const boost::system::error_code& error, size_t transferredBytes)
{
    if(error)
    {
        if( error == boost::asio::error::eof)
        {
           // 접속 종료, 대기 상태의 패킷도 보내게 한다면 필요 있는데 흠..
        }
        else
        {
            //또다른 에러 발생
            std::cout << "error No: " << error.value() << " error Message: " << error.message() << std::endl;
        }

        _server->CloseSession(_sessionID);

        return;
    }
    else
    {
        /*test*/
        cout << _receiveBuffer.data() << endl;

        string data = _receiveBuffer.data();

        data.push_back('O');
        data.push_back('O');

        RegisterSend(_receiveBuffer.size(),const_cast<char*>(data.data()));
        /*test end*/
        OnReceive(transferredBytes,_receiveBuffer.data());

        RegisterReceive();
    }
}

