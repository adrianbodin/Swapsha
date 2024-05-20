import {apiRoutes} from "@/api-routes";
import {ContactDto, PendingRequest, SentRequestDto} from "@/types/contacts";

export async function getPendingRequests() : Promise<PendingRequest[]>{
  return fetch(apiRoutes.pendingRequests, {
    credentials: 'include'
  })
    .then(res => {
      if (!res.ok) {
        console.error("Error fetching user", {status: res.status, statusText: res.statusText});
        throw new Error(`There was an error fetching the pending requests, we are sorry for the inconvenience.`)
      }
      return res.json();
    });
}

export async function getSentRequests() : Promise<SentRequestDto[]>{
  return fetch(apiRoutes.sentRequests, {
    credentials: 'include'
  })
    .then(res => {
      if (!res.ok) {
        console.error("Error getting the sent requests", {status: res.status, statusText: res.statusText});
        throw new Error(`There was an error fetching the sent requests, we are sorry for the inconvenience.`)
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
        console.error("Error", {status: res.status, statusText: res.statusText});
        throw new Error(`There was an error accepting the request, we are sorry for the inconvenience.`)
      }
      return res
    });
}

export async function sendContactRequest(userId: string){
  return fetch(`${apiRoutes.users}/${userId}/contact`, {
    method: 'POST',
    credentials: 'include'
  })
    .then(res => {
      if (!res.ok) {
        console.error("Error sending the contact request", {status: res.status, statusText: res.statusText});
        throw new Error(`There was an error sending the contact request, we are sorry for the inconvenience.`)
      }
      return res
    });
}

export async function getAllContacts() : Promise<ContactDto[]>{
  return fetch(apiRoutes.contacts, {
    credentials: 'include'
  })
    .then(res => {
      if (!res.ok) {
        console.error("Error fetching the contacts", {status: res.status, statusText: res.statusText});
        throw new Error(`There was an error fetching the contacts, we are sorry for the inconvenience.`)
      }
      return res.json();
    });
}