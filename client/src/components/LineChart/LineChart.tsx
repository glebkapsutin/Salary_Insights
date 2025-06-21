// src/components/linechart/LineChart.tsx
import React from 'react';
import { Line } from 'react-chartjs-2';
import {
  Chart as ChartJS,
  CategoryScale,
  LinearScale,
  PointElement,
  LineElement,
  Title,
  Tooltip,
  Legend,
} from 'chart.js';

ChartJS.register(CategoryScale, LinearScale, PointElement, LineElement, Title, Tooltip, Legend);

interface LineChartProps {
  data: { month: number; salary: number }[];
}

const LineChart: React.FC<LineChartProps> = ({ data }) => {
  const chartData = {
    labels: data.map((item) => item.month),
    datasets: [
      {
        label: 'Динамика зарплат',
        data: data.map((item) => item.salary),
        borderColor: '#6f42c1',
        backgroundColor: 'rgba(111, 66, 193, 0.2)',
        fill: true,
      },
    ],
  };

  const options = {
    responsive: true,
    plugins: {
      legend: { position: 'top' },
      title: { display: true, text: 'Динамика зарплат за период' },
    },
    scales: {
      y: { beginAtZero: false, title: { display: true, text: 'Зарплата (руб.)' } },
      x: { title: { display: true, text: 'Месяц' } },
    },
  };

  return <Line data={chartData} options={options} />;
};

export default LineChart;