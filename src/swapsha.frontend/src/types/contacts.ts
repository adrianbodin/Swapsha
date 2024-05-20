export interface PendingRequest{
  requestId: string;
  senderId: string;
  senderName: string;
  profilePicUrl: string;
  status: string;
}

export interface ContactDto{
  id: string;
  name: string;
  profilePictureUrl: string;
}

export interface SentRequestDto{
  requestId: string;
  receiverId: string;
  receiverName: string;
  receiverProfilePic: string;
  status: string;
}

