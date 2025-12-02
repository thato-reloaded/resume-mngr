
import { createRoot } from 'react-dom/client'
import { BrowserRouter } from "react-router-dom"
import ThemeContextProvider from './context/theme.context.tsx'
import App from './App.tsx'
import './global.scss'

createRoot(document.getElementById('root')!).render(
  <ThemeContextProvider>
    <BrowserRouter>
      <App />
    </BrowserRouter>
  </ThemeContextProvider>,
)
