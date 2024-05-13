import {apiRoutes} from "@/api-routes";
import {Profile} from "@/types/profile";

export async function getProfileInfo(): Promise<Profile> {
  return fetch(apiRoutes.profile, {
    credentials: 'include'
  })
    .then(res => {
      if (!res.ok) {
        //QUESTION is this safe to write out.
        console.error("Error fetching profile", {status: res.status, statusText: res.statusText});
        throw new Error(`There was an error fetching the profile, we are sorry for the inconvenience.`)
      }
      return res.json();
    });
}

export async function updateProfilePicture(file: File, userId: string): Promise<any> {
  const formData = new FormData();
  formData.append('image', file);

  return fetch(`${apiRoutes.root}/users/${userId}/profilepic`, {
    method: 'POST',
    body: formData,
    credentials: 'include'
  })
    .then(response => {
      if (!response.ok) {
        throw new Error('Error uploading profile picture');
      }
      return response.json();
    });
}