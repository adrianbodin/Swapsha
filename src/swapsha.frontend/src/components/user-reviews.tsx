import React, {FC} from 'react';
import {useQuery} from "react-query";
import {getUserReviewsById} from "@/fetching/users";

interface UserReviewProps{
  userId: string;
}

const UserReviews:FC<UserReviewProps> = ({ userId }) => {
  const {data, isLoading, isError } = useQuery({
    queryKey: ['review-data', userId],
    queryFn: () => getUserReviewsById(userId)
  });

  return (
    <section>
      {data?.reviews.map(review =>
        <div key={review.postedById}>
          <p>{review.rating}/5</p>
          <p>{review.comment}</p>
          <p>{review.dateCreated}</p>
        </div>)}
    </section>
  );
};

export default UserReviews;