import { BrowserRouter, Routes, Route } from "react-router-dom";
import Fourofour from "./pages/404";
import App from "./App";

export default function Router() {
    return (
      <BrowserRouter>
        <Routes>
          <Route path="/" element={<App />}>
            
          </Route>
          <Route path="*" element={<Fourofour />} />
        </Routes>
      </BrowserRouter>
    );
  }