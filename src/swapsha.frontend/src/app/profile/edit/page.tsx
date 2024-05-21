'use client'
import React from 'react';
import EditProfilePic from "@/components/profile/edit-profile-pic";
import {getProfileInfo} from "@/fetching/profile";
import {useStore} from "@/stores/user-store";
import {useQuery} from "@tanstack/react-query";
import EditName from "@/components/profile/edit-name";

const Page = () => {
  const profileId = useStore((state) => state.id);
  const { data: profile, isLoading, isError } = useQuery({
    queryKey: ['profile', profileId],
    queryFn: () => getProfileInfo(),
  })

  if (isLoading) {
    return <div>Loading...</div>;
  }

  if (isError || !profile) {
    return <div>Error...</div>;
  }

  return (
    <section className="w-full flex flex-col gap-5 items-center h-screen py-20">
      <EditProfilePic picUrl={profile?.profilePicUrl || ''} userId={profile?.id || ''}/>
      <div className="flex flex-col gap-5">
        <EditName name={profile?.firstName || ''} nameType="firstname" userId={profile.id}/>
        <EditName name={profile?.middleName || ''} nameType="middlename" userId={profile.id}/>
        <EditName name={profile?.lastName || ''} nameType="lastname" userId={profile.id}/>
      </div>
    </section>
  );
};

export default Page;