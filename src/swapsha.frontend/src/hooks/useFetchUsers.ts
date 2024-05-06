import {useEffect, useReducer, useState} from 'react';
import {toast} from "sonner";
import {
  FETCH_DONE,
  FETCH_FAILURE,
  FETCH_INIT,
  FETCH_SKILLS_SUCCESS,
  FETCH_SUCCESS,
  INITIAL_STATE,
  SET_FILTER_SKILL,
  userReducer
} from "@/reducers/userReducer";
import {SortUsersType} from "@/types/user";

export const useFetchUsers = () => {
  const [state, dispatch] = useReducer(userReducer, INITIAL_STATE);
  const [sortOption, setSortOption] = useState<SortUsersType>(SortUsersType.BestRating);

  async function fetchUsers(pageIndex: number, skillFilter?: number){
    dispatch({type: FETCH_INIT})

    const baseUrl = new URL('https://localhost:7228/api/v1/users');
    const params = new URLSearchParams({
      pageIndex: pageIndex.toString(),
      pageSize: '10',
    });

    if (skillFilter) {
      params.append('skillId', skillFilter.toString());
    }

    if (sortOption) {
      params.append('sortBy', sortOption);
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

  //When the user changes the filter select this sets this state to the choosen one
  const handleSkillChange = (e : any) => {
    const chosenSkill = state.skills.find(skill => skill.name === e.target.value);
    if(chosenSkill){
      dispatch({ type: SET_FILTER_SKILL, payload: { skill: chosenSkill } });
    }
    else {
      dispatch({ type: SET_FILTER_SKILL, payload: { skill: null}})
    }
  }

  //runs when the sort by select changes
  const handleSortChange = (e : any) => {
    setSortOption(e.target.value);
  }

  //Runs when one of the filter or sort selects change to fetch again
  useEffect(() => {
    if (state.filterSkill && state.filterSkill.id) {
      fetchUsers(1, state.filterSkill.id);
    } else {
      fetchUsers(1)
    }
  }, [state.filterSkill, sortOption]);

  //Is used to show all the skills in the dropdown
  async function fetchSkills(){
    try {
      const result = await fetch(`https://localhost:7228/api/v1/skills`);
      const json = await result.json();

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

  useEffect(() => {
    fetchUsers(state.pageInfo.pageIndex);
    fetchSkills();
  }, []);

  return { state, handleSkillChange, handleSortChange };
}