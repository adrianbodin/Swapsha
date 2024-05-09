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

    </section>
  );
};

export default UserReviews;