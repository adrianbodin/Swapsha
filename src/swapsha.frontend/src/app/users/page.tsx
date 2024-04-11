'use client'

import React, {useEffect, useState} from 'react';
import UserCard from "@/components/user-card";
import {User} from "@/types/user";
import {PageInfo} from "@/types/page-info";
import LoadingSpinner from "@/components/loading-spinner";
import {toast} from "sonner";

const UserPage = () => {
  console.log("Hello")
  const [loading, setLoading] = useState<boolean>(false)
  const [error, setError] = useState<boolean>(false)
  const [users, setUsers] = useState<User[]>([])
  const [pageInfo, setPageInfo] = useState<PageInfo>({
    pageIndex: 1,
    pageSize: 10,
    totalRecords: 0
  })

  //Function to fetch the users and set the state with the data
  async function fetchUsers(pageIndex: number){

    setLoading(true);

    try {
      const result = await fetch(`https://localhost:7228/api/v1/users?pageIndex=${pageIndex}&pageSize=10`);
      const json = await result.json();

      setUsers(json.data);
      setPageInfo({
        pageIndex: json.pageIndex,
        pageSize: json.pageSize,
        totalRecords: json.totalRecords
      });
      setError(false)
    }
    catch (error){
      toast.error("There was an error fetching the users");
      setError(true);
    }
    finally {
      setLoading(false);
    }

  }

  //This runs when the component is initialized
  useEffect(() => {
    fetchUsers(pageInfo.pageIndex)
  }, []);

  return (
    <section className="mt-10 mb-40">
      <h2 className="text-center text-2xl font-bold">Lets find the best match for your project!</h2>
      {loading &&
          <div className="flex justify-center items-center h-dvh">
              <LoadingSpinner />
          </div>}
      {error &&
          <div className="flex justify-center items-center h-dvh">
              <h3 className="underline font-bold text-2xl">Error, please try again later.</h3>
          </div>}
      <div className="grid grid-cols-1 gap-10 pt-10 md:grid-cols-2">
        {!loading && users.map(user =>
              <UserCard key={user.userId} user={user}/>
          )}
      </div>
    </section>
  );
};

export default UserPage;