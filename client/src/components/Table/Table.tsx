// src/components/table/Table.tsx
import React from 'react';

interface TableProps {
  data: { profession: string; relevance: string; salary: string; popularity: string }[];
}

const Table: React.FC<TableProps> = ({ data }) => {
  return (
    <table>
      <thead>
        <tr>
          <th>Профессия</th>
          <th>Актуальность</th>
          <th>Средняя ЗП</th>
          <th>Популярность</th>
        </tr>
      </thead>
      <tbody>
        {data.map((row, index) => (
          <tr key={index}>
            <td>{row.profession}</td>
            <td>{row.relevance}</td>
            <td>{row.salary}</td>
            <td>{row.popularity}</td>
          </tr>
        ))}
      </tbody>
    </table>
  );
};

export default Table;