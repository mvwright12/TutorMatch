import { Photo } from './photo';

export interface User {
    id: number;
    username: string;
    studentTutor: string;
    gender: string;
    year: string;
    subjects: string;
    availability: string;
    rateRange: string;
    created: Date;
    lastActive: any;
    photoUrl: string;
    city: string;
    state: string;
    introduction?: string;
    photos?: Photo[];
}
