import React, {FC} from 'react';
import {getUserReviewsById} from "@/fetching/users";
import Link from "next/link";
import {useQuery} from "@tanstack/react-query";

interface UserReviewProps{
  userId: string;
}

const UserReviews:FC<UserReviewProps> = ({ userId }) => {

  const {data, isLoading, isError } = useQuery({
    queryKey: ['review-data', userId],
    queryFn: () => getUserReviewsById(userId)
  });

  if (isLoading) return <p>Loading reviews...</p>

  if (isError) return <p>There was an error loading the reviews...</p>

  return (
    <section className="grid grid-cols-1 sm:grid-cols-2 gap-5">
      {data?.reviews.map(review =>
        <div key={review.reviewId} className="bg-main-white p-4 w-full rounded-md flex flex-col gap-2">
          <p className="font-bold">{review.rating}/5</p>
          <p>{review.comment}</p>
          <p>Posted: <span className="font-bold">{review.dateCreated}</span> by:
            <Link className="font-bold hover:underline" href={`/users/${review.postedById}`}> {review.postedBy}</Link></p>
        </div>)}
    </section>
  );
};

export default UserReviews;