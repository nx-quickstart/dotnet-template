import { api } from '@dotnet-template/frontend-utils';
import { User } from '@dotnet-template/generated/backend-types';

export default async function Index() {
  const user = await api.get<User[]>('User');

  return (
    <div>
      <h1>Index</h1>
      <p>{user.data[0].name}</p>
    </div>
  );
}
