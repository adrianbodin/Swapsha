import {useQuery} from "@tanstack/react-query";
import {getAllContacts} from "@/fetching/contacts";
import LoadingSpinner from "@/components/loading-spinner";
import React from "react";
import Image from "next/image";
import Link from "next/link";

const AllContacts = () => {
  const {data: contacts, isLoading, isError} = useQuery({
    queryKey: ['contacts'],
    queryFn: getAllContacts
  })

  if(isLoading){
    return <div className="flex justify-center items-center h-dvh">
      <LoadingSpinner/>
    </div>
  }

  if(isError) {
    return <div className="flex justify-center items-center h-dvh">
      <p className="font-bold text-xl">Error fetching the contact.</p>
    </div>
  }

  if(contacts?.length === 0){
    return <div className="flex justify-center items-center h-dvh">
      <p className="font-bold text-xl">You have no contacts.</p>
    </div>
  }

  return (
    <section className="w-full gap-5 grid grid-cols-1 md:grid-cols-2">
      {contacts?.map((contact) => (
        <div key={contact.id} className="bg-main-white flex items-center justify-between gap-5  p-5 rounded-md">
          <div className="relative w-20 h-20 overflow-hidden rounded-full">
            <Image
              src={contact.profilePictureUrl}
              alt="Profile picture"
              fill
              objectFit="cover"
            />
          </div>
          <Link href={`/users/${contact.id}`}>
            <h3 className="font-bold text-lg hover:underline">{contact.name}</h3>
          </Link>
          <Link href="/chat">
            <button
              className="bg-light-green flex justify-center items-center p-3 rounded-full shadow-md shadow-gray-400">
              <span className="material-symbols-outlined">
                chat
              </span>
            </button>
          </Link>
        </div>
      ))}
    </section>
  );
};

export default AllContacts;