// src/features/filtersSlice.ts
import { createSlice, PayloadAction } from '@reduxjs/toolkit';

interface FiltersState {
  category: string;
  profession: string;
  year: string;
  level: string;
}

const initialState: FiltersState = {
  category: 'Development',
  profession: 'Frontend Developer',
  year: '2023',
  level: 'Удачливо',
};

const filtersSlice = createSlice({
  name: 'filters',
  initialState,
  reducers: {
    setFilters(state, action: PayloadAction<Partial<FiltersState>>) {
      return { ...state, ...action.payload };
    },
  },
});

export const { setFilters } = filtersSlice.actions;
export default filtersSlice.reducer;