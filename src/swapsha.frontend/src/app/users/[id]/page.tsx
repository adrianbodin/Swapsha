'use client'
import React, {FC, useEffect, useState} from 'react';
import {fetchUserById} from "@/fetching/users";
import Image from "next/image";
import UserReviews from "@/components/user-reviews";
import UserBio from "@/components/user-bio";
import {SingleUser} from "@/types/user";
import {useMutation, useQuery, useQueryClient} from "@tanstack/react-query";
import {useStore} from "@/stores/user-store";
import {getSentRequests, sendContactRequest} from "@/fetching/contacts";
import {toast} from "sonner";

interface UserPageProps {
  params: {
    id: string;
  }
}

type ViewType = 'bio' | 'reviews'
type ContactState = 'Contact' | 'Sent'

const UserPage: FC<UserPageProps> = ({ params: { id: userId } }) => {
  const [currentView, setCurrentView] = useState<ViewType>('bio');
  const isLoggedIn = useStore((state) => state.isLoggedIn);
  const [contactState, setContactState] = useState<ContactState>('Contact')
  const queryClient = useQueryClient();

  const {data: user, isLoading, isError} = useQuery<SingleUser>({
    queryKey: ['user', userId],
    queryFn: () => fetchUserById(userId)
  })

  const {data: sentRequests} = useQuery({
    queryKey: ['sent-requests'],
    queryFn: getSentRequests
  })

  const sendRequest = useMutation({
    mutationFn: (userId: string) => sendContactRequest(userId),
    onSuccess: async () => {
      await queryClient.invalidateQueries({queryKey: ['sent-requests']})
      setContactState('Sent');
      toast.success(`Contact request sent to ${user?.fullName}`);
    },
    onError: () => {
      toast.error(`There was an error sending a request to ${user?.fullName}`)
    }
  })

  useEffect(() => {
    if (sentRequests?.some(request => request.receiverId === user?.userId)) {
      setContactState('Sent');
    }
  }, [sentRequests, user?.userId]);

  //TODO fix better tags for these
  if (isLoading) return <p>Loading...</p>

  if (isError) return <p>There was an error...</p>

  return (
    <section className="py-5">
      <div className="flex justify-center items-center">
        <div className="relative w-80 h-80 overflow-hidden rounded-full">
          <Image
            src={user?.profilePictureUrl || ""}
            alt="Profile picture"
            fill
            objectFit="cover"
          />
        </div>
      </div>
      <div className="flex flex-col items-center justify-center py-8">
        <h2 className="font-bold text-3xl mb-1">{user?.fullName}</h2>
          <div className="flex">
            <span className="material-symbols-outlined">
              location_on
            </span>
            <h3 className="font-bold">{user?.city}</h3>
          </div>
        <div className="flex">
          <span className="material-symbols-outlined">
            stars
          </span>
          <h4 className="font-bold">{user?.averageRating}/5 | {user?.totalReviews} Reviews</h4>
        </div>
      </div>
      <div className="flex justify-center gap-4 mb-10">
        {isLoggedIn &&
        <button
            className="basis-1/3 px-4 py-2 bg-light-green text-xl font-bold rounded-xl text-main-white shadow-sm shadow-black"
            onClick={() => sendRequest.mutate(user?.userId || '')}
            disabled={contactState === 'Sent'}>
          {/* todo fix this to a better text*/}
          {contactState}
        </button>}
        <button
          className="basis-1/3 px-4 py-2 bg-main-white text-xl font-bold rounded-xl shadow-sm shadow-gray-400"
          onClick={() => setCurrentView('reviews')}>
          Reviews
        </button>
        <button
          className="basis-1/3 px-4 py-2 bg-main-white text-xl font-bold rounded-xl shadow-sm shadow-gray-400"
          onClick={() => setCurrentView('bio')}>
          Bio
        </button>
      </div>
      {currentView === 'bio' &&
        <UserBio bio={user?.bio} skills={user?.skills} wantedSkills={user?.wantedSkills} />}
      {currentView === 'reviews' &&
        <UserReviews userId={userId} />}
    </section>
  );
};

export default UserPage;