// src/components/barchart/BarChart.tsx
import React from 'react';
import { Bar } from 'react-chartjs-2';
import {
  Chart as ChartJS,
  CategoryScale,
  LinearScale,
  BarElement,
  Title,
  Tooltip,
  Legend,
} from 'chart.js';

ChartJS.register(CategoryScale, LinearScale, BarElement, Title, Tooltip, Legend);

interface BarChartProps {
  data: { year: string; count: number }[];
}

const BarChart: React.FC<BarChartProps> = ({ data }) => {
  const chartData = {
    labels: data.map((item) => item.year),
    datasets: [
      {
        label: 'Количество наймов',
        data: data.map((item) => item.count),
        backgroundColor: '#007bff',
        borderColor: '#0056b3',
        borderWidth: 1,
      },
    ],
  };

  const options = {
    responsive: true,
    plugins: {
      legend: { position: 'top' },
      title: { display: true, text: 'Количество наймов за период' },
    },
    scales: {
      y: { beginAtZero: true, title: { display: true, text: 'Количество' } },
      x: { title: { display: true, text: 'Год' } },
    },
  };

  return <Bar data={chartData} options={options} />;
};

export default BarChart;