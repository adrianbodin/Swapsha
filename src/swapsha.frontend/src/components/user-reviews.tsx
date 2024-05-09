import React, {FC} from 'react';
import {useQuery} from "react-query";
import {getUserReviewsById} from "@/fetching/users";
import Link from "next/link";

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
    <section>
      {data?.reviews.map(review =>
        <div key={review.reviewId} className="bg-main-white my-3 p-2 rounded-md flex flex-col gap-2">
          <p className="font-bold">{review.rating}/5</p>
          <p>{review.comment}</p>
          <p>Posted: <span className="font-bold">{review.dateCreated}</span> by:
            <Link className="font-bold hover:underline" href={`/users/${review.postedById}`}> {review.postedBy}</Link></p>
        </div>)}
    </section>
  );
};

export default UserReviews;