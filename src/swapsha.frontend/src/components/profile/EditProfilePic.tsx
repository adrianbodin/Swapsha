import React, { FC } from 'react';
import Image from "next/image";

interface EditProfilePicProps{
  profilePicUrl: string
}

const EditProfilePic: FC<EditProfilePicProps> = ({ profilePicUrl }) => {
  return (
    <Image
      src={profilePicUrl}
      alt="profile picture"
      height={400}
      width={400}/>
  );
};

export default EditProfilePic;
