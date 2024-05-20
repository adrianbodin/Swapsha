import React, { FC } from 'react';
import {useMutation, useQuery, useQueryClient} from "@tanstack/react-query";
import {acceptRequest, declineRequest, getPendingRequests} from "@/fetching/contacts";
import LoadingSpinner from "@/components/loading-spinner";
import Image from "next/image";
import Link from "next/link";
import {toast} from "sonner";

const PendingRequests = () => {
  const queryClient = useQueryClient();

  const {data: requests, isLoading, isError} = useQuery({
    queryKey: ['pending-requests'],
    queryFn: getPendingRequests
  })

  const accept = useMutation({
    mutationFn: (requestId: string) => acceptRequest(requestId),
    onSuccess: async () => {
      toast.success("The request has been accepted! To to your contacts to view.")
      await queryClient.invalidateQueries({queryKey: ['pending-requests']})
    },
    onError: () => {
      toast.error("There was an error accepting the request, please try again.")
    }
  })

  const decline = useMutation({
    mutationFn: (requestId: string) => declineRequest(requestId),
    onSuccess: async () => {
      toast.success("The request was successfully declined.")
      await queryClient.invalidateQueries({queryKey: ['pending-requests']})
    },
    onError: () => {
      toast.error("There was an error declining the request, please try again.")
    }
  })

  if(isLoading){
    return <div className="flex justify-center items-center h-dvh">
             <LoadingSpinner/>
           </div>
  }

  if(isError) {
   return <div className="flex justify-center items-center h-dvh">
            <p className="font-bold text-xl">Error fetching the pending requests</p>
          </div>
  }

  if(requests?.length === 0){
    return <div className="flex justify-center items-center h-dvh">
             <p className="font-bold text-xl">You have no pending requests</p>
           </div>
  }

  return (
    <section className="w-full gap-5 grid grid-cols-1 md:grid-cols-2">
      {requests?.map((request) => (
        <div key={request.requestId} className="bg-main-white flex items-center justify-between gap-5  p-5 rounded-md">
          <div className="relative w-20 h-20 overflow-hidden rounded-full">
            <Image
              src={request.profilePicUrl}
              alt="Profile picture"
              fill
              objectFit="cover"
            />
          </div>
          <Link href={`/users/${request?.senderId}`}>
            <h3 className="font-bold text-lg hover:underline">{request.senderName}</h3>
          </Link>
          <div className="flex flex-col gap-2">
            <button
              onClick={() => accept.mutate(request.requestId)}
              className="px-2 py-1 bg-green-600 font-bold rounded-xl text-main-white shadow-sm shadow-black">
              Accept
            </button>
            <button
              onClick={() => decline.mutate(request.requestId)}
              className="px-2 py-1 bg-red-600 font-bold rounded-xl text-main-white shadow-sm shadow-black">
              Decline
            </button>
          </div>
        </div>
      ))}
    </section>
  );
};

export default PendingRequests;
