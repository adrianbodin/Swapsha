﻿import React, {FC} from 'react';
import Image from "next/image";
import {User} from "@/types/user";
import Link from "next/link";

interface UserCardProps{
  user: User
}

const UserCard: FC<UserCardProps> = ({ user }) => {
  return (
    <div className="w-full h-64 bg-main-white shadow-2xl rounded-2xl flex">
        <Image
          className="rounded-l-2xl w-1/2"
          src={user.profilePictureUrl ? user.profilePictureUrl : "/images/user-card-image.jpg"}
          alt="Picture of a user"
          width={400}
          height={400}
          style={{objectFit:"cover"}}
        />
      <div className="w-1/2 p-3 flex flex-col justify-between">
        <div className="flex gap-3">
          {user.totalReviews
            ?
              <>
                  <p className="underline">{user.averageRating}/5</p>
                  <p>{user.totalReviews} Reviews</p>
              </>
            :
              <p>No Reviews</p>}
        </div>
        <p className="font-bold text-xl">{user.fullName}</p>
        <ul className="list-disc ml-4">
          {user.skills.slice(0, 3).map(skill => (
            <li key={skill}>{skill}</li>
          ))}
          {user.skills.length > 4  && <p>and {user.skills.length - 3} more...</p>}
        </ul>
        <Link href={`/users/${user.userId}`}>
          <button className="inline-block px-4 py-2 bg-light-green text-xl font-bold rounded-xl text-main-white shadow-sm shadow-black">Details</button>
        </Link>
      </div>
    </div>
  );
};

export default UserCard;