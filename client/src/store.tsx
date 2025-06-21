// src/store.ts
import { configureStore } from '@reduxjs/toolkit';
import filtersReducer from './features/filtersSlice';
import dataReducer from './features/dataSlice';

export const store = configureStore({
  reducer: {
    filters: filtersReducer,
    data: dataReducer,
  },
});

export type RootState = ReturnType<typeof store.getState>;
export type AppDispatch = typeof store.dispatch;