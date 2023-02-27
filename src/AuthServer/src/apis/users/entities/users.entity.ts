import { Field, Int, ObjectType } from '@nestjs/graphql'
import { Jobs } from 'src/apis/jobs/entities/jobs.entity'
import { Column, Entity, JoinColumn, ManyToMany, OneToMany, OneToOne, PrimaryGeneratedColumn } from 'typeorm'


@Entity()
@ObjectType()
export class User {

    @PrimaryGeneratedColumn("uuid")
    @Field(() => String)
    primKey: string

    @Column()
    @Field(() => String)
    email: string

    @Column()
    psword: string

    @Column()
    @Field(() => String)
    nickname: string

    @Column()
    @Field(() => Int)
    level: number

    @Column()
    @Field(() => Int)
    cash: number

    @Column()
    @Field(() => Int)
    exp: number

    @Column()
    @Field(() => Boolean)
    emailCheck: boolean

    @Column()
    @Field(() => Date)
    regDate: Date

    @Column()
    @Field(() => Date)
    updateDate: Date

    @Column()
    @Field(() => Date)
    recentDate: Date

    @JoinColumn()
    @OneToOne(() => Jobs)
    jobs: Jobs


}