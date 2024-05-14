﻿'use client'
import React from 'react';
import EditProfilePic from "@/components/profile/edit-profile-pic";
import {getProfileInfo} from "@/fetching/profile";
import {useStore} from "@/stores/user-store";
import {useQuery} from "@tanstack/react-query";

const Page = () => {
  const profileId = useStore((state) => state.id);
  const { data: profile, isLoading, isError } = useQuery({
    queryKey: ['profile', profileId],
    queryFn: () => getProfileInfo()
  })

  return (
    <section className="w-full h-screen py-5">
      <EditProfilePic picUrl={profile?.profilePicUrl || ''} userId={profile?.id || ''}/>
    </section>
  );
};

export default Page;