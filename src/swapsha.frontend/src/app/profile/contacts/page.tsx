'use client'

import React, {useState} from 'react';
import PendingRequests from "@/components/profile/contacts/pending-requests";
import AllContacts from "@/components/profile/contacts/all-contacts";
import SentRequests from "@/components/profile/contacts/sent-requests";

type ContactPageState = 'pending-requests' | 'sent-requests' | 'all-contacts'

const ContactPage = () => {
  const [state, setState] = useState<ContactPageState>('all-contacts');

  return (
    <section className="py-5">
      <div className="flex justify-center gap-4 mb-10">
        <button
          className={`basis-1/3 px-4 py-2 text-xl font-bold rounded-xl shadow-sm shadow-gray-400
           ${state === 'pending-requests' ? `text-main-white bg-light-green shadow-lg` : `bg-main-white`}`}
          onClick={() => setState('pending-requests')}>
          Pending Requests
        </button>
        <button
          className={`basis-1/3 px-4 py-2 text-xl font-bold rounded-xl shadow-sm shadow-gray-400
           ${state === 'all-contacts' ? `text-main-white bg-light-green shadow-lg` : `bg-main-white`}`}
          onClick={() => setState('all-contacts')}>
          All Contacts
        </button>
        <button
          className={`basis-1/3 px-4 py-2 text-xl font-bold rounded-xl shadow-sm shadow-gray-400
           ${state === 'sent-requests' ? `text-main-white bg-light-green shadow-lg` : `bg-main-white`}`}
          onClick={() => setState('sent-requests')}>
          Sent Requests
        </button>
      </div>
      <div>
        {state === 'pending-requests' && <PendingRequests/>}
        {state === 'all-contacts' && <AllContacts/>}
        {state === 'sent-requests' && <SentRequests/>}
      </div>
    </section>
  );
};

export default ContactPage;