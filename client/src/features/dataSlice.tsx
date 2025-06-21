// src/features/dataSlice.ts
import { createSlice, PayloadAction } from '@reduxjs/toolkit';

interface DataState {
  hires: { year: string; count: number }[];
  salaryTrends: { month: number; salary: number }[];
  rankings: { profession: string; relevance: string; salary: string; popularity: string }[];
}

const initialState: DataState = {
  hires: [],
  salaryTrends: [],
  rankings: [],
};

const dataSlice = createSlice({
  name: 'data',
  initialState,
  reducers: {
    setData(state, action: PayloadAction<DataState>) {
      return { ...state, ...action.payload };
    },
  },
});

export const { setData } = dataSlice.actions;
export default dataSlice.reducer;