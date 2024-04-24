'use client'

import React, {useEffect, useReducer, useState} from 'react';
import UserCard from "@/components/user-card";
import {User} from "@/types/user";
import {PageInfo} from "@/types/page-info";
import LoadingSpinner from "@/components/loading-spinner";
import {toast} from "sonner";
import {FETCH_DONE, FETCH_FAILURE, FETCH_INIT, FETCH_SUCCESS, INITIAL_STATE, userReducer} from "@/reducers/userReducer";

const UserPage = () => {
  const [state, dispatch] = useReducer(userReducer, INITIAL_STATE)

  //Function to fetch the users and set the state with the data
  async function fetchUsers(pageIndex: number){
    dispatch({type: FETCH_INIT})
    try {
      const result = await fetch(`https://localhost:7228/api/v1/users?pageIndex=${pageIndex}&pageSize=30`);
      const json = await result.json();

      dispatch({type: FETCH_SUCCESS, payload: {
          users: json.data,
          pageInfo: {
            pageIndex: json.pageIndex,
            pageSize: json.pageSize,
            totalRecords: json.totalRecords
          }
        }})
    }
    catch (error){
      toast.error("There was an error fetching the users");
      dispatch({type: FETCH_FAILURE});
    }
    finally {
      dispatch({type: FETCH_DONE})
    }
  }

  //This runs when the component is initialized
  useEffect(() => {
    fetchUsers(state.pageInfo.pageIndex)
  }, []);

  return (
    <section className="mt-10 mb-40">
      <h2 className="text-center text-2xl font-bold">Lets find the best match for your project!</h2>
      {state.loading &&
          <div className="flex justify-center items-center h-dvh">
              <LoadingSpinner />
          </div>}
      {state.error &&
          <div className="flex justify-center items-center h-dvh">
              <h3 className="underline font-bold text-2xl">Error, please try again later.</h3>
          </div>}
      <div className="grid grid-cols-1 gap-10 pt-10 md:grid-cols-2">
        {!state.loading && state.users.map(user =>
              <UserCard key={user.userId} user={user}/>
          )}
      </div>
    </section>
  );
};

export default UserPage;