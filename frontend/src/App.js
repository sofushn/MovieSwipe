import './App.css';
import GroupSection from './components/GroupSection';
import MovieCard from './components/MovieCard.js';
import MenuSelection from './components/MenuSelection.js';

function App() {
  return (
    <div className="App container">
      <div className='row'>
        <div className='col-2 group-section-col'>
          <GroupSection />
        </div>

        <div className='col'>
          <MovieCard
            imgSource="picsum.photos/200/300"
            title="Movie title"
            year="Movie year release"
          />
        </div>

        <div className='col-2 group-section-col'>
          <MenuSelection />
        </div>
      </div>
    </div >
  );
}

export default App;
