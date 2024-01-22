# NxQuickstartWeb

This project was created to speed-up development proccess and give a set of pre-configurated tools includind Prisma, TypeORM , shadcn-ui , tailwindCSS, Next.js, Nest.js

<a alt="Nx logo" href="https://nx.dev" target="_blank" rel="noreferrer"><img src="https://raw.githubusercontent.com/nrwl/nx/master/images/nx-logo.png" width="45"></a>

## Features

1. Full integration with `NX`
2. `.NET` and `Next.js` out of the box
3. Already configuration with `Microsoft.EntityFrameworkCore`
4. Out of the box configuration with `postgreSQL`, which means you just have to setup `postgreSQL` enviroment or use default ones.
5. `Docker` integration that setup development `postgreSQL` for you. You just need to install docker on your system and launch the `docker-engine`
6. `Swagger` integrtion inclusive `Swagger typescript generator`
7. If you prefer to use `shadcn-ui`, now `nx-quickstart` have fully integration with this ui library

## Start the app

1. Install necessary dependecies on you system

   - (.NET SDK 8.0.1)[https://dotnet.microsoft.com/en-us/download/dotnet/8.0]
   - (.NET SDK 7)[https://dotnet.microsoft.com/en-us/download/dotnet/7.0] (because Swashbuckle.AspNetCore 6.5.0 that is used on template is using .NET SDK 7) if you want to generate typescript types from swagger
   - `pnpm` package manager

2. Generate a nx project template this will install all necessary dependencies and promts your preferences.

```bash
npx nx-quickstart@latest
```

3. Provide your specific postgreSQL enviroment or use default one that is generead by docker-compose file in [tools/docker/dev.docker-compose.yml](tools/docker/dev.docker-compose.yml)

4. Compose docker container

```bash
pnpm run db:up
```

5. Update database with latest migrations

```bash
pnpm run db:update
```

6. Run development server

```bash
pnpm run dev
```

5. Open your browser and navigate to http://localhost:4200/. Happy coding!

## package.json scripts explanation

    "dev": running docker container , concurrently runs frontend and backend

    "dev:api": runs development server of `backend`

    "dev:web": runs development server of `frontend`

    "dev:swagger-codegen": generates typescript types from swagger documentation

    "db:up": compose a docker container from [tools/docker/dev.docker-compose.yml](tools/docker/dev.docker-compose.yml) file

    "db:migrate": adds db migration

    "db:update": updates db with recently added migrations

## Other Templates

[Prisma-Template](https://github.com/nx-quickstart/prisma-template)
[Typeorm-Template](https://github.com/nx-quickstart/typeorm-template)

This is the templates used for nx projects generation. We also support contribution to them , so feel free to check it.

## Generate code

If you happen to use Nx plugins, you can leverage code generators that might come with it.

Run `nx list` to get a list of available plugins and whether they have generators. Then run `nx list <plugin-name>` to see what generators are available.

Learn more about [Nx generators on the docs](https://nx.dev/plugin-features/use-code-generators).

## Running tasks

To execute tasks with Nx use the following syntax:

```
nx <target> <project> <...options>
```

You can also run multiple targets:

```
nx run-many -t <target1> <target2>
```

..or add `-p` to filter specific projects

```
nx run-many -t <target1> <target2> -p <proj1> <proj2>
```

Targets can be defined in the `package.json` or `projects.json`. Learn more [in the docs](https://nx.dev/core-features/run-tasks).

## Want better Editor Integration?

Have a look at the [Nx Console extensions](https://nx.dev/nx-console). It provides autocomplete support, a UI for exploring and running tasks & generators, and more! Available for VSCode, IntelliJ and comes with a LSP for Vim users.

## Ready to deploy?

Just run `nx build demoapp` to build the application. The build artifacts will be stored in the `dist/` directory, ready to be deployed.

## Set up CI!

Nx comes with local caching already built-in (check your `nx.json`). On CI you might want to go a step further.

- [Set up remote caching](https://nx.dev/core-features/share-your-cache)
- [Set up task distribution across multiple machines](https://nx.dev/nx-cloud/features/distribute-task-execution)
- [Learn more how to setup CI](https://nx.dev/recipes/ci)

## Connect with us!

- [mike.gurin21@gmail.com](mailto:mike.gurin21@gmail.com)
