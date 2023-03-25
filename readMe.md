## 프로젝트 개요
![PVE 게임](https://user-images.githubusercontent.com/40656425/221360737-dd27c513-c0cc-468a-809d-aeb4a35922eb.png)
- 멀티플레이 2D 슈팅 게임
> 인증 로비 부터 PVE, PVP(서버) 까지 모두 직접 만드는 게임


## 개발 기간
- 1/23 ~ 2/21

### 개발 인원 : 5명
| 이름 | 개인 깃허브 | 담당 역할 및 기능 |
| ------ | ---------- | ------ |
| 김성신 |    | <img src="https://img.shields.io/badge/-BE-red"> 매칭 서버, 유니티 네트워크 매니저 |
| 정휘찬 |  | <img src="https://img.shields.io/badge/-BE-red"> 게임 서버     |
| 서민지 |            | <img src="https://img.shields.io/badge/-FE-blue"> 로비 UI |
| 설민우 |          | <img src="https://img.shields.io/badge/-FE-blue"> 게임 클라이언트, 포톤 |
| 신지훈 |          | <img src="https://img.shields.io/badge/-BE-red"> 매치 서버|
<br/>

## 기술 스택
<img src="https://img.shields.io/badge/Unity-FFFFFF?style=for-the-badge&logo=Unity&logoColor=black"> 클라이언트\
<img src="https://img.shields.io/badge/C++-00599C?style=for-the-badge&logo=C++&logoColor=white"> 게임 서버\
<img src="https://img.shields.io/badge/C Sharp-239120?style=for-the-badge&logo=C Sharp&logoColor=white"> 매칭 서버\
<img src="https://img.shields.io/badge/Node.js-339933?style=for-the-badge&logo=Node.js&logoColor=white"> 로비 서버\
<img src="https://img.shields.io/badge/NestJS-E0234E?style=for-the-badge&logo=NestJS&logoColor=white"> 인증 서버


## 주요 기능
- 이메일 인증을 통한 회원가입 기능
- 토큰 인증을 이용한 로그인 기능
- 실시간 멀티플레이 기능
- 상점 구매 기능
- 인벤토리 관리 기능
- 게임 서버
  - 방 생성 및 유저 입장
  - 30fps(33ms)
  - 캐릭터, 투사체 이동 처리(방향 × 속도)
  - 투사체와 유저 사이의 거리 계산으로 피격(둘 사이 거리 < 특정 거리)
  - 이동 패킷(방향 위치) 받아서 유저 정보 갱신
  - 공격 패킷(정규 벡터) 받아서 투사체 생성
  - 종료 조건: 접속한 클라이언트가 없을 때 or 게임 내 유저가 1명만 남았을 때

## 아키텍처
![image](https://user-images.githubusercontent.com/40656425/221357105-8fa68669-98f0-497e-9e9b-ea692981225e.png)

## UI

<details>
<summary>접기/펼치기 버튼</summary>
<div markdown="1">

### 게임 접속
[이미지](https://github.com/sgdevcamp2022/ants/blob/main/img/ForReadMe/%EB%A1%9C%EA%B7%B8%EC%9D%B8.png)

### 회원 가입
[이미지](https://github.com/sgdevcamp2022/ants/blob/main/img/ForReadMe/%ED%9A%8C%EC%9B%90%EA%B0%80%EC%9E%85.png)

### 게임 로비
[이미지](https://github.com/sgdevcamp2022/ants/blob/main/img/ForReadMe/%EA%B2%8C%EC%9E%84%20%EB%A1%9C%EB%B9%84.png)

### 채팅
[이미지](https://github.com/sgdevcamp2022/ants/blob/main/img/ForReadMe/%EC%B1%84%ED%8C%85.png)

### 설정
[이미지](https://github.com/sgdevcamp2022/ants/blob/main/img/ForReadMe/%EC%84%A4%EC%A0%95.png)

### 상점
[이미지](https://github.com/sgdevcamp2022/ants/blob/main/img/ForReadMe/%EC%83%81%EC%A0%90.png)

### 인벤토리
[이미지](https://github.com/sgdevcamp2022/ants/blob/main/img/ForReadMe/%EC%9D%B8%EB%B2%A4%ED%86%A0%EB%A6%AC.png)

### 게임모드 선택
[이미지](https://github.com/sgdevcamp2022/ants/blob/main/img/ForReadMe/%EA%B2%8C%EC%9E%84%EB%AA%A8%EB%93%9C%20%EC%84%A0%ED%83%9D.png)

### PVP 게임
[이미지](https://github.com/sgdevcamp2022/ants/blob/main/img/ForReadMe/PVP%20%EA%B2%8C%EC%9E%84.png)

### PVE 게임
[이미지](https://github.com/sgdevcamp2022/ants/blob/main/img/ForReadMe/PVE%20%EA%B2%8C%EC%9E%84.png)

### PVE 방 목록 및 방생성
[이미지](https://github.com/sgdevcamp2022/ants/blob/main/img/ForReadMe/PVE%20%EB%B0%A9%20%EB%AA%A9%EB%A1%9D%20%EB%B0%8F%20%EC%83%9D%EC%84%B1.png)

### PVE 대기방
[이미지](https://github.com/sgdevcamp2022/ants/blob/main/img/ForReadMe/PVE%20%EB%8C%80%EA%B8%B0%EB%B0%A9.png)

### PVE 게임
[이미지](https://github.com/sgdevcamp2022/ants/blob/main/img/ForReadMe/PVE%20%EA%B2%8C%EC%9E%84.png)

</div>
</details>




## PMP
[파일 링크](https://github.com/sgdevcamp2022/ants/blob/main/doc/PPT/%5BPMP%5D%20%EC%A0%84%EB%9D%BC_Ants.pdf)
## 중간 발표
[파일 링크](https://github.com/sgdevcamp2022/ants/blob/main/doc/PPT/%5B%EC%A4%91%EA%B0%84%EB%B0%9C%ED%91%9C%5D%20%EC%A0%84%EB%9D%BC_Ants.pdf)
## 최종 발표
[파일 링크](https://github.com/sgdevcamp2022/ants/blob/main/doc/PPT/%5B%EC%B5%9C%EC%A2%85%EB%B0%9C%ED%91%9C%5D%20%EC%A0%84%EB%9D%BC_Ants.pdf)
## 위험 관리
[파일 링크](https://github.com/sgdevcamp2022/ants/tree/main/doc/risk_management)
## 팀 목표 및 회고
![image](https://user-images.githubusercontent.com/40656425/221360536-9da8fa45-2645-4f97-ba65-14583c3198a4.png)


정휘찬
- [회고록](https://velog.io/@oak_cassia/%ED%94%84%EB%A1%9C%EC%A0%9D%ED%8A%B8%EC%97%90%EC%84%9C-%EC%96%BB%EC%9D%80-%EA%B2%83)
- [프로젝트에서 배운것](https://velog.io/@oak_cassia/%ED%94%84%EB%A1%9C%EC%A0%9D%ED%8A%B8%EC%97%90%EC%84%9C-%EB%B0%B0%EC%9A%B4-%EA%B2%83)
