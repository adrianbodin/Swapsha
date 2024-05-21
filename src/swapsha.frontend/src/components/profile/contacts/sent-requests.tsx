import LoadingSpinner from "@/components/loading-spinner";
import React from "react";
import {useQuery} from "@tanstack/react-query";
import Image from "next/image";
import Link from "next/link";
import {getSentRequests} from "@/fetching/contacts";

const SentRequests = () => {
  const {data: requests, isLoading, isError} = useQuery({
    queryKey: ['sent-requests'],
    queryFn: getSentRequests
  })

  if(isLoading){
    return <div className="flex justify-center items-center h-dvh">
      <LoadingSpinner/>
    </div>
  }

  if(isError) {
    return <div className="flex justify-center items-center h-dvh">
      <p className="font-bold text-xl">Error fetching the requests.</p>
    </div>
  }

  if(requests?.length === 0){
    return <div className="flex justify-center items-center h-dvh">
      <p className="font-bold text-xl">You have no sent requests.</p>
    </div>
  }

  return (
    <section className="w-full gap-5 grid grid-cols-1 md:grid-cols-2">
      {requests?.map((request) => (
        <div key={request.requestId} className="bg-main-white flex items-center justify-between gap-5  p-5 rounded-md">
          <div className="relative w-20 h-20 overflow-hidden rounded-full">
            <Image
              src={request.receiverProfilePic}
              alt="Profile picture"
              fill
              className="object-cover"
              sizes="200px"
            />
          </div>
          <Link href={`/users/${request.receiverId}`}>
            <h3 className="font-bold text-lg hover:underline">{request.receiverName}</h3>
          </Link>
          <h3>{request.status}...</h3>
        </div>
      ))}
    </section>
  );
};

export default SentRequests;