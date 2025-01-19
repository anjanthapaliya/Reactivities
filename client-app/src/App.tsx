import { useEffect, useState } from "react";
import "./App.css";
import axios from "axios";
import { Header, HeaderContent, Icon, List, ListItem } from "semantic-ui-react";
import "semantic-ui-css/semantic.min.css";

function App() {
  const [activities, setActivities] = useState([]);

  useEffect(() => {
    axios.get("http://localhost:5000/api/activities").then((response) => {
      console.log(response);
      setActivities(response.data);
    });
  }, []);

  return (
    <>
      <Header as="h2" icon="users" content="Reactivities" />

      <List>
        {activities.map((activity: any) => (
          <ListItem key={activity.id}>{activity.title}</ListItem>
        ))}
      </List>
    </>
  );
}

export default App;
