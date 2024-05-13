﻿'use client'
import React from 'react';
import EditProfilePic from "@/components/profile/edit-profile-pic";
import {useQuery} from "react-query";
import {getProfileInfo} from "@/fetching/profile";

const ProfilePage = () => {
  const { data: profile, isLoading, isError } = useQuery({
    queryKey: ['profile'],
    queryFn: () => getProfileInfo()
  })

  return (
    <section className="w-full h-screen py-5">
      <EditProfilePic picUrl={profile?.profilePicUrl || ''} userId={profile?.id || ''}/>
    </section>
  );
};

export default ProfilePage;