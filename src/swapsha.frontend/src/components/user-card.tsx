import React from 'react';
import Image from "next/image";

const UserCard = () => {
  return (
    <div className="w-full bg-main-white rounded-2xl flex">
      <div className="w-1/2">
        <Image
          className="rounded-l-2xl"
          src="/images/user-card-image.jpg"
          alt="Picture of a user"
          width={640}
          height={427}
        />
      </div>
      <div className="w-1/2">

      </div>
    </div>
  );
};

export default UserCard;