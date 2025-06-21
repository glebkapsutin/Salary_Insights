// src/components/dashboard/Dashboard.tsx
import React, { useEffect } from 'react';
import { useSelector, useDispatch } from 'react-redux';
import { setFilters } from '../../features/filtersSlice';
import { fetchData } from '../../features/dataSlice';
import { RootState } from '../../store';
import styles from './Dashboard.module.css';

const Dashboard: React.FC = () => {
  const dispatch = useDispatch();
  const filters = useSelector((state: RootState) => state.filters);

  useEffect(() => {
    dispatch(fetchData(filters) as any);
  }, [dispatch, filters]);

  const handleFilterChange = (e: React.ChangeEvent<HTMLSelectElement>) => {
    dispatch(setFilters({ [e.target.name]: e.target.value }));
  };

  return (
    <div className={styles.dashboard}>
      <header className={styles.header}>
        <input
          type="text"
          placeholder="Найти должность..."
          className={styles.searchInput}
        />
        <select
          name="category"
          value={filters.category}
          onChange={handleFilterChange}
          className={styles.filterSelect}
        >
          <option value="Development">Development</option>
          <option value="Frontend Developer">Frontend Developer</option>
        </select>
        <select
          name="profession"
          value={filters.profession}
          onChange={handleFilterChange}
          className={styles.filterSelect}
        >
          <option value="Middle">Middle</option>
          <option value="Senior">Senior</option>
        </select>
        <select
          name="year"
          value={filters.year}
          onChange={handleFilterChange}
          className={styles.filterSelect}
        >
          <option value="2023">2023</option>
          <option value="2024">2024</option>
        </select>
        <select
          name="level"
          value={filters.level}
          onChange={handleFilterChange}
          className={styles.filterSelect}
        >
          <option value="Удачливо">Удачливо</option>
          <option value="Обычно">Обычно</option>
        </select>
      </header>
    </div>
  );
};

export default Dashboard;