import {apiRoutes} from "@/api-routes";
import {PendingRequest} from "@/types/contacts";

export async function getPendingRequests() : Promise<PendingRequest[]>{
  return fetch(apiRoutes.pendingRequests, {
    credentials: 'include'
  })
    .then(res => {
      if (!res.ok) {
        //QUESTION is this safe to write out.
        console.error("Error fetching user", {status: res.status, statusText: res.statusText});
        throw new Error(`There was an error fetching the pending requests, we are sorry for the inconvenience.`)
      }
      return res.json();
    });
}

export async function declineRequest(requestId: string){
  return fetch(`${apiRoutes.root}/profile/contact-requests/${requestId}/decline`, {
    method: 'PUT',
    credentials: 'include'
  })
    .then(res => {
      if (!res.ok) {
        //QUESTION is this safe to write out.
        console.error("Error fetching user", {status: res.status, statusText: res.statusText});
        throw new Error(`There was an error declining the request, we are sorry for the inconvenience.`)
      }
      return res
    });
}

export async function acceptRequest(requestId: string){
  return fetch(`${apiRoutes.root}/profile/contact-requests/${requestId}/approve`, {
    method: 'PUT',
    credentials: 'include'
  })
    .then(res => {
      if (!res.ok) {
        //QUESTION is this safe to write out.
        console.error("Error fetching user", {status: res.status, statusText: res.statusText});
        throw new Error(`There was an error accepting the request, we are sorry for the inconvenience.`)
      }
      return res
    });
}