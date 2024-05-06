export interface User {
  userId: string;
  email: string;
  fullName: string;
  profilePictureUrl: string;
  totalReviews: number | null;
  averageRating: number | null;
  skills: string[];
}

export enum SortUsersType{
  BestRating = "best-rating",
  MostRatings = "most-ratings"
}