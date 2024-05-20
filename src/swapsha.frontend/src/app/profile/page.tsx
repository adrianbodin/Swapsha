import React from 'react';
import Link from "next/link";

const Page = () => {
  return (
    <section className="py-5 h-dvh flex items-center">
      <div className="flex flex-col gap-2 w-full">
        <Link href="/profile/edit" className="basis-1/2">
          <button className="w-full p-10 rounded-md bg-main-white shadow-lg shadow-gray-400 ">
            <h3 className="font-bold text-4xl hover:underline">
              Edit Profile
            </h3>
          </button>
        </Link>
        <Link href="/profile/contacts" className="basis-1/2">
          <button className="w-full p-10 rounded-md bg-main-white shadow-lg shadow-gray-400 ">
            <h3 className="font-bold text-4xl hover:underline">
              Contacts
            </h3>
          </button>
        </Link>
      </div>
    </section>
  );
};

export default Page;