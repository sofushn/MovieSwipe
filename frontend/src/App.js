import './App.css';
import MovieCard from './components/MovieCard.js';

function App() {
  return (
    <div className="App">

      <MovieCard
        imgSource="picsum.photos/200/300"
        title="Movie title"
        year="Movie year release"
      />
      
    </div>
  );
}

export default App;
