'use client'
import React, {FC} from 'react';
import {useQuery} from "react-query";
import {fetchUserById} from "@/fetching/users";
import Image from "next/image";

interface UserPageProps {
  params: {
    id: string;
  }
}

const UserPage: FC<UserPageProps> = ({ params: { id: userId } }) => {
  const {data: user, isLoading, isError} = useQuery({
    queryKey: ['user', userId],
    queryFn: () => fetchUserById(userId)
  })


  if (isLoading) return <p>Loading...</p>

  if (isError) return <p>There was an error...</p>

  return (
    <section className="py-5">
      <div className="relative w-80 h-80 flex justify-center items-center overflow-hidden rounded-full">
        <Image
          src={user?.profilePictureUrl || ""}
          alt="Profile picture"
          fill
          objectFit="cover"
        />
      </div>
      <div className="flex flex-col items-center justify-center py-8">
        <h2 className="font-bold text-3xl mb-1">{user?.fullName}</h2>
          <div className="flex">
            <span className="material-symbols-outlined">
              location_on
            </span>
            <h3 className="font-bold">{user?.city}</h3>
          </div>
      </div>
      <div className="flex flex-col items-center mb-10">
        <h3 className="font-bold text-2xl mb-2">I am good at:</h3>
        <ul>
          {user?.skills.map(skill =>
            <li className="list-disc text-xl" key={skill.id} >{skill.name}</li>
          )}
        </ul>
      </div>
      <div className="flex flex-col items-center mb-10">
        <h3 className="font-bold text-2xl mb-2">I am looking for:</h3>
        <ul>
          {user?.wantedSkills.map(wantedSkill =>
            <li className="list-disc text-xl" key={wantedSkill.id} >{wantedSkill.name}</li>
          )}
        </ul>
      </div>
    </section>
  );
};

export default UserPage;