import { createContext, useState } from "react";

interface IThemeContexInterface {
    darkMode: boolean;
    toggleDarkMode: () => void;
}

export const ThemeContext = createContext<IThemeContexInterface>({
    darkMode: false,
    toggleDarkMode: () => {},
});

interface IThemeContextProviderProps {
    children: React.ReactNode;
}

const ThemeContextProvider = ({ children }: IThemeContextProviderProps) => {
    const [darkMode, setDarkMode] = useState<boolean>(false);

    const toggleDarkMode: () => void = () => {
        setDarkMode((prevMode) => !prevMode);
    };

    return <ThemeContext.Provider value={{ darkMode, toggleDarkMode }}>{children}</ThemeContext.Provider>;
}

export default ThemeContextProvider;
