import React, {FC} from 'react';
import Image from "next/image";
import {User} from "@/types/user";
import Link from "next/link";

interface UserCardProps{
  user: User
}

const UserCard: FC<UserCardProps> = ({ user }) => {
  return (
    <div className="w-full h-64 bg-main-white shadow-2xl rounded-2xl flex">
      <div className="w-1/2 relative h-full">
        <Image
          className="rounded-l-2xl h-full"
          src={user.profilePictureUrl ? user.profilePictureUrl : "/images/user-card-image.jpg"}
          alt="Picture of a user"
          width={640}
          height={427}
          style={{objectFit:"cover"}}
        />
      </div>
      <div className="w-1/2 p-3 flex flex-col justify-between">
        <div className="flex gap-3">
          <p className="underline">{user.averageRating}/5</p>
          <p>{user.totalReviews} reviews</p>
        </div>
        <p className="font-bold text-xl">{user.fullName}</p>
        <ul className="list-disc ml-4">
          {user.skills.slice(0, 3).map(skill => (
            <li key={skill}>{skill}</li>
          ))}
          {user.skills.length > 4  && <p>and {user.skills.length - 3} more...</p>}
        </ul>
        <Link href={`/users/${user.userId}`}>
          <button className="inline-block px-4 py-2 bg-light-green text-xl font-bold rounded-xl text-main-white shadow-sm shadow-black">Contact</button>
        </Link>
      </div>
    </div>
  );
};

export default UserCard;