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
  userId: string | undefined;
  fullName: string | undefined;
  city: string | undefined;
  bio: string | undefined;
  profilePictureUrl?: string | undefined;
  totalReviews: number | null;
  averageRating: number | null;
  skills: Skill[] | undefined;
  wantedSkills: Skill[] | undefined;
}

interface Review {
  reviewId: number;
  rating: number;
  comment: string;
  dateCreated: string;
  postedById: string;
  postedBy: string;
}

export interface UserReviewsResponse{
  totalReviews: number;
  averageReviews: number;
  reviews: Review[];
}

export enum SortUsersType{
  BestRating = "best-rating",
  MostRatings = "most-ratings"
}