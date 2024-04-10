import React from 'react';

interface UserPageProps {
  params: {
    id: string;
  }
}

const UserPage = ({ params }: UserPageProps) => {
  return (
    <div>
      <p>{params.id}</p>
    </div>
  );
};

export default UserPage;