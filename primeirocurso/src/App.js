import logo from './logo.svg';
import './App.css';
import Banner from './components/Banner/Banner';

function App() {
  return (
    <div className="App">
      <Banner></Banner>
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Wellcome to React!
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Murinas?Amigao?
        </a>
      </header>
    </div>
  );
}

export default App;
