import React, {FC} from 'react';

interface UserPageProps {
  params: {
    id: string;
  }
}

const UserPage: FC<UserPageProps> = ({ params }) => {
  return (
    <div>
      <p>{params.id}</p>
    </div>
  );
};

export default UserPage;