import { StrictMode } from "react";
import { createRoot } from "react-dom/client";
import "./app/layouts/styles.css";
import App from "./app/layouts/App";

createRoot(document.getElementById("root")!).render(
  <StrictMode>
    <App />
  </StrictMode>
);
