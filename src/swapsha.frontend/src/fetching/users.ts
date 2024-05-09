import {SingleUser, User, UserReviewsResponse} from "@/types/user";
import {apiRoutes} from "@/api-routes";

export async function fetchUserById(id: string): Promise<SingleUser> {
  return fetch(`${apiRoutes.root}/users/${id}`)
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
  return fetch(`${apiRoutes.root}/users/${userId}/reviews`)
    .then(res => {
      if (!res.ok) {
        //QUESTION is this safe to write out.
        console.error("Error fetching user", {status: res.status, statusText: res.statusText});
        throw new Error(`There was an error fetching the reviews of the user, we are sorry for the inconvenience.`)
      }
      return res.json();
    });
}