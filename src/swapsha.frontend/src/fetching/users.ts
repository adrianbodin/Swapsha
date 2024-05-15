import {GetAllUsersResponse, SingleUser, SortUsersType, User, UserReviewsResponse} from "@/types/user";
import {apiRoutes} from "@/api-routes";
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

export async function updateFirstName(userId: string, name: string) {
  return fetch(`${apiRoutes.root}/users/${userId}/firstname`, {
    method: 'PATCH',
    credentials: 'include',
    headers: {
      'Content-Type': 'application/json'
    },
    body: JSON.stringify({ firstName: name})
  })
    .then(res => {
      if (!res.ok) {
        //QUESTION is this safe to write out.
        console.log("error")
        console.error("Error adding the firstname", {status: res.status, statusText: res.statusText});
        throw new Error(`There was an error updating the firstname, we are sorry for the inconvenience.`)
      }
      return res
    });
}

export async function updateMiddleName(userId: string, name: string) {
  return fetch(`${apiRoutes.root}/users/${userId}/middlename`, {
    method: 'PATCH',
    credentials: 'include',
    headers: {
      'Content-Type': 'application/json'
    },
    body: JSON.stringify({ middleName: name})
  })
    .then(res => {
      if (!res.ok) {
        //QUESTION is this safe to write out.
        console.error("Error adding the middlename", {status: res.status, statusText: res.statusText});
        throw new Error(`There was an error updating the middlename, we are sorry for the inconvenience.`)
      }
      return res;
    });
}

export async function updateLastName(userId: string, name: string) {
  return fetch(`${apiRoutes.root}/users/${userId}/lastname`, {
    method: 'PATCH',
    credentials: 'include',
    headers: {
      'Content-Type': 'application/json'
    },
    body: JSON.stringify({ lastName: name})
  })
    .then(res => {
      if (!res.ok) {
        //QUESTION is this safe to write out.
        console.error("Error adding the lastname", {status: res.status, statusText: res.statusText});
        throw new Error(`There was an error updating the lastname, we are sorry for the inconvenience.`)
      }
      return res;
    });
}