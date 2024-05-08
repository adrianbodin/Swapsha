'use client'
import React, {FC} from 'react';
import {useQuery} from "react-query";
import {apiRoutes} from "@/api-routes";

interface UserPageProps {
  params: {
    id: string;
  }
}

const UserPage: FC<UserPageProps> = ({ params }) => {
  const {data: user, isLoading, isError} = useQuery({
    queryKey: ['user', params.id],
    queryFn: () => fetch(`${apiRoutes.root}/users/${params.id}`).then(res => res.json())
  })

  if (isLoading) return <p>Loading...</p>

  if (isError) return <p>Error...</p>

  return (
    <div>
      <p>{user.city}</p>
    </div>
  );
};

export default UserPage;