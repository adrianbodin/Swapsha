import {GetAllUsersResponse, SingleUser, SortUsersType, User, UserReviewsResponse} from "@/types/user";
import {apiRoutes} from "@/api-routes";
import NumericSeparatorTransformer from "sucrase/dist/types/transformers/NumericSeparatorTransformer";
import {FETCH_DONE, FETCH_FAILURE, FETCH_INIT, FETCH_SUCCESS} from "@/reducers/userReducer";
import {toast} from "sonner";

export async function fetchUserById(id: string): Promise<SingleUser> {
  return fetch(`${apiRoutes.root}/users/${id}`, {
    credentials: 'include'
  })
    .then(res => {
      if (!res.ok) {
        //QUESTION is this safe to write out.
        console.error("Error fetching user", {status: res.status, statusText: res.statusText});
        throw new Error(`There was an error fetching user, we are sorry for the inconvenience.`)
      }
      return res.json();
    });
}

export async function getUserReviewsById(userId: string): Promise<UserReviewsResponse> {
  return fetch(`${apiRoutes.root}/users/${userId}/reviews`, {
    credentials: 'include'
  })
    .then(res => {
      if (!res.ok) {
        //QUESTION is this safe to write out.
        console.error("Error fetching user", {status: res.status, statusText: res.statusText});
        throw new Error(`There was an error fetching the reviews of the user, we are sorry for the inconvenience.`)
      }
      return res.json();
    });
}

export async function getAllUsers(pageIndex: number = 1, sortBy?: string, skillId?: number, pageSize: number = 10 ): Promise<GetAllUsersResponse> {

  const baseUrl = new URL(apiRoutes.users);
  const params = new URLSearchParams({
    pageIndex: pageIndex.toString(),
    pageSize: '10',
  });

  if (skillId) {
    params.append('skillId', skillId.toString());
  }

  if (sortBy) {
    params.append('sortBy', sortBy);
  }

  baseUrl.search = params.toString();

  try {
    return fetch(baseUrl.toString(), { credentials: 'include' })
      .then(res => {
        if(!res.ok){
          throw new Error("There was an error fetching the users")
        }
        return res.json()
      })
  }
  catch (error){
    toast.error("There was an error fetching the users");
    return Promise.reject(error);
  }
}