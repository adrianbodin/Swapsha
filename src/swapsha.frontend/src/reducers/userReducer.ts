import {User} from "@/types/user";
import {PageInfo} from "@/types/page-info";

export const INITIAL_STATE: State ={
  loading: false,
  users: [],
  skills: [],
  error: false,
  filterSkill: null,
  pageInfo: {
    pageIndex: 1,
    pageSize: 10,
    totalRecords: 0
  }
}

// Define the action types as constants
export const FETCH_INIT = 'FETCH_INIT';
export const FETCH_SUCCESS = 'FETCH_SUCCESS';
export const FETCH_FAILURE = 'FETCH_FAILURE';
export const FETCH_DONE = 'FETCH_DONE';
export const FETCH_SKILLS_SUCCESS = 'FETCH_SKILLS_SUCCESS';
export const SET_FILTER_SKILL = 'SET_FILTER_SKILL';
export const NEXT_PAGE = 'NEXT_PAGE';
export const PREVIOUS_PAGE = 'PREVIOUS_PAGE';

type Action =
  | { type: typeof FETCH_INIT }
  | { type: typeof FETCH_SUCCESS; payload: { users: User[]; pageInfo: PageInfo } }
  | { type: typeof FETCH_SKILLS_SUCCESS; payload: { skills: Skill[]}}
  | { type: typeof FETCH_FAILURE;}
  | { type: typeof FETCH_DONE; }
  | { type: typeof SET_FILTER_SKILL; payload: {skill: Skill | null}}
  | { type: typeof NEXT_PAGE}
  | { type: typeof PREVIOUS_PAGE}


// Update the State type to include an error message
type State = {
  loading: boolean;
  error: boolean
  users: User[];
  filterSkill: Skill | null;
  skills: Skill[]
  pageInfo: PageInfo;
};

// Update the reducer to handle the error message
export const userReducer = (state: State, action: Action): State => {
  switch (action.type) {
    case FETCH_INIT:
      return { ...state, loading: true};
    case FETCH_SUCCESS:
      return { ...state, loading: false, users: action.payload.users, pageInfo: action.payload.pageInfo };
    case FETCH_SKILLS_SUCCESS:
      return { ...state, loading: false, skills: action.payload.skills };
    case FETCH_FAILURE:
      return { ...state, loading: false, error: true };
    case FETCH_DONE:
      return { ...state, loading: false };
    case SET_FILTER_SKILL:
      return { ...state, filterSkill: state.filterSkill ? action.payload.skill : action.payload.skill };
    case NEXT_PAGE:
      const newPageIndex = state.pageInfo.pageIndex + 1;
      return { ...state, pageInfo: { ...state.pageInfo, pageIndex: newPageIndex } }
    case PREVIOUS_PAGE:
      const previousPageIndex = state.pageInfo.pageIndex - 1;
      return { ...state, pageInfo: { ...state.pageInfo, pageIndex: previousPageIndex } }
    default:
      throw new Error();
  }
};