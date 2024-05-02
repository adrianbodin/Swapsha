'use client'

import React, {useEffect, useReducer, useState} from 'react';
import UserCard from "@/components/user-card";
import LoadingSpinner from "@/components/loading-spinner";
import {toast} from "sonner";
import {
  FETCH_DONE,
  FETCH_FAILURE,
  FETCH_INIT,
  FETCH_SKILLS_SUCCESS,
  FETCH_SUCCESS,
  INITIAL_STATE, SET_FILTER_SKILL,
  userReducer
} from "@/reducers/userReducer";

const UserPage = () => {
  const [state, dispatch] = useReducer(userReducer, INITIAL_STATE)

  //Function to fetch the users and set the state with the data
  async function fetchUsers(pageIndex: number, skillFilter?: number){
    dispatch({type: FETCH_INIT})

    const baseUrl = new URL('https://localhost:7228/api/v1/users');
    const params = new URLSearchParams({
      pageIndex: pageIndex.toString(),
      pageSize: '30',
    });

    if (skillFilter) {
      params.append('skillId', skillFilter.toString());
    }

    baseUrl.search = params.toString();

    try {
      const result = await fetch(baseUrl.toString())
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

  async function fetchSkills(){
    try {
      const result = await fetch(`https://localhost:7228/api/v1/skills`);
      const json = await result.json();

      console.log(json)

      dispatch({type: FETCH_SKILLS_SUCCESS, payload: { skills: json }})
    }
    catch (error){
      toast.error("There was an error fetching the skills for the filters");
      dispatch({type: FETCH_FAILURE});
    }
    finally {
      dispatch({type: FETCH_DONE})
    }
  }

  //This runs when the component is initialized
  useEffect(() => {
    fetchUsers(state.pageInfo.pageIndex);
    fetchSkills();
  }, []);

  useEffect(() => {
    if (state.filterSkill && state.filterSkill.id) {
      fetchUsers(1, state.filterSkill.id);
    } else {
      fetchUsers(1);
    }
  }, [state.filterSkill]);

  return (
    <section className="mt-10 mb-40">
      <h2 className="text-center text-2xl mb-10 font-bold">Lets find the best match for your project!</h2>
      <select className="p-2 rounded-md"
              name="skill-select"
              id="skill-select"
              onChange={(e) => {
                const chosenSkill = state.skills.find(skill => skill.name === e.target.value);
                if(chosenSkill){
                  dispatch({ type: SET_FILTER_SKILL, payload: { skill: chosenSkill } });
                }
                else {
                  dispatch({ type: SET_FILTER_SKILL, payload: { skill: null}})
                }
              }}>
        <option value="">Filter by Skill</option>
        {state.skills && state.skills.map((skill) =>
            <option key={skill.id} value={skill.name}>{skill.name}</option>)}
      </select>
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