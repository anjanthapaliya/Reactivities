import { Button, Container, Menu } from "semantic-ui-react";

interface Props {
  openForm: () => void;
}
export default function NavBar({ openForm }: Props) {
  return (
    <Menu inverted fixed="top">
      <Container>
        <Menu.Item name="header">
          <img src="/assets/logo.png" alt="logo" style={{ marginRight: 20 }} />
          Reactivities
        </Menu.Item>
        <Menu.Item name="Activities" />
        <Menu.Item>
          <Button positive content="Create Activity" onClick={openForm} />
        </Menu.Item>
      </Container>
    </Menu>
  );
}
