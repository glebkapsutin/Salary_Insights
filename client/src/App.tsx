// src/App.tsx
import React from 'react';
import Dashboard from './components/Dashboard/Dashboard';

const App: React.FC = () => {
  return (
    <div className="app">
      <h1>PayPulse</h1>
      <Dashboard />
    </div>
  );
};

export default App;