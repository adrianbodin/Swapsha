'use client'
import React from 'react';
import EditProfilePic from "@/components/profile/EditProfilePic";
import {useQuery} from "react-query";
import {getProfileInfo} from "@/fetching/profile";

const ProfilePage = () => {
  const { data: profile, isLoading, isError } = useQuery({
    queryKey: 'profile',
    queryFn: () => getProfileInfo()
  })

  return (
    <section className="w-full h-screen">
      <EditProfilePic profilePicUrl={profile?.profilePicUrl || ''}/>
    </section>
  );
};

export default ProfilePage;