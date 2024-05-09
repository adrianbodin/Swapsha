export interface User {
  userId: string;
  fullName: string;
  city: string;
  profilePictureUrl?: string;
  totalReviews: number | null;
  averageRating: number | null;
  skills: string[];
}

export interface SingleUser{
  userId: string;
  fullName: string;
  city: string;
  profilePictureUrl?: string;
  skills: Skill[];
  wantedSkills: Skill[];
}

export enum SortUsersType{
  BestRating = "best-rating",
  MostRatings = "most-ratings"
}