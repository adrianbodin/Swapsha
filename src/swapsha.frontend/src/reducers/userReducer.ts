import {useState} from "react";
import {User} from "@/types/user";
import {PageInfo} from "@/types/page-info";

export const INITIAL_STATE: State ={
  loading: false,
  users: [],
  error: false,
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

type Action =
  | { type: typeof FETCH_INIT }
  | { type: typeof FETCH_SUCCESS; payload: { users: User[]; pageInfo: PageInfo } }
  | { type: typeof FETCH_FAILURE;}
  | { type: typeof FETCH_DONE };

// Update the State type to include an error message
type State = {
  loading: boolean;
  error: boolean
  users: User[];
  pageInfo: PageInfo;
};

// Update the reducer to handle the error message
export const userReducer = (state: State, action: Action): State => {
  switch (action.type) {
    case FETCH_INIT:
      return { ...state, loading: true};
    case FETCH_SUCCESS:
      return { ...state, loading: false, users: action.payload.users, pageInfo: action.payload.pageInfo };
    case FETCH_FAILURE:
      return { ...state, loading: false, error: true };
    case FETCH_DONE:
      return { ...state, loading: false };
    default:
      throw new Error();
  }
};