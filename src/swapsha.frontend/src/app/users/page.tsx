import React from 'react';
import UserCard from "@/components/user-card";

const Page = () => {

  //fetch all the users here and then pass it down to the other components

  return (
    <section className="mt-10">
      <h2 className="text-center text-2xl font-bold">Lets find the best match for your project!</h2>
      <div className="grid grid-cols-1 gap-10 pt-10 md:grid-cols-2">
        <UserCard/>
        <UserCard/>
        <UserCard/>
        <UserCard/>
      </div>
    </section>
  );
};

export default Page;